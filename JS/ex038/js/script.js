function Calcular() {
    const input = document.getElementById('number');
    const label = document.getElementById('label');

    let n = parseInt(input.value);

    if (isNaN(n) || n < 0) {
        alert("Digite um número inteiro maior ou igual a 0!");
        return;
    }

    if (n === 0) {
        label.innerText = "0! = 1";
        return;
    }

    let fatorial = 1;

    for (let i = 1; i <= n; i++) {
        fatorial *= i;
    }

    label.innerText = `${fatorial}`;
}
