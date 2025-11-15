const numeros = [];
const label = document.getElementById('label');
const input = document.getElementById('num1');

function Submeter() {
    const valor = parseFloat(input.value);

    if (isNaN(valor)) {
        alert("Digite um número válido!");
        input.value = '';
        input.focus();
        return;
    }

    if (valor === 9999) {
        if (numeros.length === 0) {
            label.innerText = "Nenhum número foi digitado.";
            return;
        }

        const soma = numeros.reduce((acc, curr) => acc + curr, 0);
        const media = soma / numeros.length;

        label.innerHTML = `
            <p>Soma = ${soma}</p>
            <p>Média = ${media.toFixed(2)}</p>
        `;

        numeros.length = 0;
        input.value = '';
        input.focus();
        return;
    }

    numeros.push(valor);
    input.value = '';
    input.focus();

}
