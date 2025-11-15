let numeros = [];
let i = 1;

function Receber() {
    const input = document.getElementById("input");
    const texto = document.getElementById("texto");
    const label = document.getElementById("label");
    const valor = Number(input.value);

    if (input.value === "") return;

    if (i <= 10) {
        numeros.push(valor);
        texto.textContent = `Digite o ${i + 1}º valor`;
        input.value = "";
        i++;

        if (i === 11) {
            texto.textContent = "Digite o número de comparação";
            input.value = "";
        }
    } else {
        const menores = numeros.filter(n => n < valor).length;
        label.innerHTML = `
            <p>Você digitou ${menores} números menores que ${valor}.</p>
        `;
        texto.textContent = "Fim do exercício";
        input.disabled = true;
    }
}
