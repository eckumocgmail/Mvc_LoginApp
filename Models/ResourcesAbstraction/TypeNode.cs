using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ApplicationCommon.CommonTypes
{
    /// <summary>
    /// Иерархическая структура данных
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TypeNode<T>
    {
        /// <summary>
        /// Уникальное имя обьекта в родительском контексте
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Элемент
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// Дочерние элементы
        /// </summary>
        public ConcurrentDictionary<string, TypeNode<T>> Children { get; set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="item"></param>
        /// <param name="parent"></param>
        public TypeNode( string name, T item, TypeNode<T> parent )
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            Name = name;
            Item = item;
            Parent = parent;
            Children = new ConcurrentDictionary<string, TypeNode<T>>();
        }


        /// <summary>
        /// Удаление дочернего элемента
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Remove(string name)
        {
            TypeNode<T> output;
            return Children.TryRemove(name,out output);
        }


        /// <summary>
        /// Проверка наличия потомка с заданным именем
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Has(string name)
        {
            return Children.ContainsKey(name);
        }


        /// <summary>
        /// Добавление потомка
        /// </summary>
        /// <param name="pchild"></param>
        /// <returns></returns>
        public TypeNode<T> Append(TypeNode<T> pchild)
        {
            if(pchild == null)
            {
                throw new ArgumentNullException("pchild");
            }
            if (Has(pchild.Name))
            {
                throw new Exception($"Обьек с именем {pchild.Name} уже зарегистрирован в узле: {GetPath()}");
            }
            else
            {
                return Children[pchild.Name] = pchild;
            }
        }


        /// <summary>
        /// Ссылка на родительский элемент
        /// </summary>
        private TypeNode<T> _Parent { get; set; }


        /// <summary>
        /// Перемещение узла
        /// </summary>
        public TypeNode<T> Parent 
        {
            get
            {
                return _Parent;
            }
            set
            {
                if(_Parent !=null)
                {
                    _Parent.Remove(Name);
                }
                if( value != null)
                {
                    _Parent = value;
                    _Parent.Append(this);
                }
                
            }
        }


        /// <summary>
        /// Получение пути от истока
        /// </summary>
        /// <returns></returns>
        public List<string> GetPath()
        {
            if( Parent != null)
            {
                List<string> path = Parent.GetPath();
                path.Add(Name);
                return path;
            }
            return new List<string> { Name };
        }


        /// <summary>
        /// Получение абсолюного идентификатора
        /// </summary>
        /// <param name="separator">разделитель</param>
        /// <returns></returns>
        public string GetPath(string separator)
        {
            string path = "";
            foreach(string name in GetPath())
            {
                if (path.Length != 0)
                {
                    path += separator + name;
                }
                else
                {
                    path = name;
                }
            }
            return path;
        }


        /// <summary>
        /// Обработка узлов поддерева вертикально вниз
        /// </summary>
        /// <typeparam name="TNode"></typeparam>
        /// <param name="handle"></param>
        public void DoBroadcastToChildren<TNode>( Action<TNode> handle ) where TNode : TypeNode<T>
        {
            handle((TNode)this);
            foreach(TypeNode<T> pchild in Children.Values)
            {
                pchild.DoBroadcastToChildren<TNode>(handle);
            }
        }


        /// <summary>
        /// Обработка узлов поддерева снизу вверх
        /// </summary>
        /// <typeparam name="TNode"></typeparam>
        /// <param name="handle"></param>
        public void DoBroadcastFromChildren<TNode>(Action<TNode> handle) where TNode : TypeNode<T>
        {            
            foreach (TypeNode<T> pchild in Children.Values)
            {
                pchild.DoBroadcastFromChildren<TNode>(handle);
            }
            handle((TNode)this);
        }


        /// <summary>
        /// Обход всей иерархии
        /// </summary>
        /// <typeparam name="TNode"></typeparam>
        /// <param name="handle"></param>
        public void DoBroadcastToParent<TNode>(Action<TNode> handle) where TNode : TypeNode<T>
        {
            handle((TNode)this);
            if(Parent!=null)
            {
                Parent.DoBroadcastToParent<TNode>(handle);
            }
        }


        /// <summary>
        /// Обработка узлов поддерева сверху вниз
        /// </summary>
        /// <typeparam name="TNode"></typeparam>
        /// <param name="handle"></param>
        public void DoBroadcastToBrothers<TNode>(Action<TNode> handle) where TNode : TypeNode<T>
        {            
            if(Parent == null)
            {
                handle((TNode)this);
            }
            foreach (TypeNode<T> pchild in Children.Values)
            {
                handle((TNode)pchild);                
            }
            foreach (TypeNode<T> pchild in Children.Values)
            {
                pchild.DoBroadcastToBrothers<TNode>(handle);
            }            
        }


    
        
    }
}
