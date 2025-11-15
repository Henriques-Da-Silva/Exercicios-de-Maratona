const numeros = []

function Submeter() {
    const input = document.getElementById('num');
    const label = document.getElementById('label');
    const h2 = document.querySelector('h2');
    const valor = parseInt(input.value);

    if (isNaN(valor)) {
        alert("Digite um número válido!");
        return;
    }

    numeros.push(valor)
    input.value = ''
    input.focus()

    if (numeros.length < 10) {
        h2.innerText = `Digite o ${numeros.length + 1}º número:`;
    } else {
        const soma = numeros.reduce((acc, curr) => acc + curr, 0);
        const media = soma / numeros.length;

        const maior = Math.max(...numeros);
        const menor = Math.min(...numeros);

        label.innerHTML = `<p>Média: ${media}</p> <p>Maior: ${maior}</p> <p>Menor: ${menor}</p>`;
        h2.innerText = "Digite o 1º número:";
        numeros.length = 0;
    }
}
