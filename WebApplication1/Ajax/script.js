window.onload = function () {

    document.getElementById('btn1').addEventListener('click', function () {
        const request = new XMLHttpRequest();
        const url = "/WebService1.asmx/Method_GET_CARS";
        request.open("POST", url);
        request.setRequestHeader("Content-type", "application/json; charset=utf-8");
        request.addEventListener("readystatechange", () => {

            if (request.readyState === 4 && request.status === 200) {
                let res = JSON.parse(request.responseText);
                let cars = JSON.parse(res.d);

                let renderCars = cars.map(car => {
                    return `<tr><td>${car.Model}</td><td>${car.fuel}</td></tr>`;
                }).join("");
                document.getElementById('cars').innerHTML = `<tr><th>Model</th><th>Fuel</th></tr>${renderCars}`;
            }
        });
        request.send();
    })
    document.getElementById('btn2').addEventListener('click', function () {
        const request = new XMLHttpRequest();
        const url = "/WebService1.asmx/Method_GET_FUELS";
        request.open("POST", url);
        request.setRequestHeader("Content-type", "application/json; charset=utf-8");
        request.addEventListener("readystatechange", () => {

            if (request.readyState === 4 && request.status === 200) {
                let res = JSON.parse(request.responseText);
                let fuels = JSON.parse(res.d);

                let renderFuels = fuels.map(f => {
                    return `<tr><td>${f.fuel}</td></tr>`;
                }).join("");
                document.getElementById('fuels').innerHTML = `<tr><th>Fuel</tr>${renderFuels}`;
            }
        });
        request.send();
    })
}