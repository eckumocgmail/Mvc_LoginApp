using System;

namespace AppModel.Areas.User.Pages.Messages
{
    public class BasePageModel
    {
        private IServiceProvider provider;

        public BasePageModel(IServiceProvider provider)
        {
            this.provider = provider;
        }
    }
}