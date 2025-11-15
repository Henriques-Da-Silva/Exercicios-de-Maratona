const label = document.getElementById("label");
    const texto = "1 2 3 4 5 6 7 8 9 10";
    let resultado = "";

    for (let i = 1; i <= 10; i++) {
        resultado += `${i}, ${texto}<br>`;
    }

    label.innerHTML = resultado;