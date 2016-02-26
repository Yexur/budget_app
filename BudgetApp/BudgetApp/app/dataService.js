
function loadAllUsersSummary() {
    var data
    var xhr = new XMLHttpRequest();
    xhr.open('get', '/userSummary', false);
    xhr.onload = function () {
        data = JSON.parse(xhr.responseText);        
    }
    xhr.send();
    return data;
}



