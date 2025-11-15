const label = document.getElementById("label");
let resultado = "<p>";

for (let i = 7; i < 1000; i += 7) {
    resultado += i + " ";
}

resultado += "</p>";
label.innerHTML = resultado;
