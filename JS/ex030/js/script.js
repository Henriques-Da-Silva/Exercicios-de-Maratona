const label = document.getElementById("label");
let resultado = "<p>";
let soma = 0;

for (let i = 85; i >= 31; i--) {
    if (i % 2 === 0) {
        resultado += i + " ";
        soma += i;
    }
}

resultado += `</p><p><strong>Soma:</strong> ${soma}</p>`;
label.innerHTML = resultado;