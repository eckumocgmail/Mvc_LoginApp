
// возвращает текст htnl-таблица
function $table(properties) {
    let html = '<table>';
    html += '<tr><td>Свойство</td><td>Значение</td></tr>';
    const names = Object.getOwnPropertyNames(properties);
    for (let i = 0; i < names.length; i++) {
        if ((properties[names[i]]) instanceof Array == false) {
            if (typeof (properties[names[i]]) == 'object') {
                html += '<tr><td>' + names[i] + '</td>' +
                    '<td>' + $table(properties[names[i]]) + '</td></tr>';

            } else {
                html += '<tr><td>' + names[i] + '</td>' +
                    '<td>' + properties[names[i]] + '</td></tr>';
            }
        } else {
            let text = '';
            const arr = properties[names[i]];
            for (let i = 0; i < arr.length; i++) {
                text += `<div>${arr[i]}</div>`;
            }
            html += '<tr><td>' + names[i] + '</td>' +
                '<td>' + text + '</td></tr>';
        }
    }
    html += '</table>';
    return html;
}