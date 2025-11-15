function Multiplicar() {
    const num1 = parseInt(document.getElementById('num1').value);
    const num2 = parseInt(document.getElementById('num2').value);
    const label = document.getElementById('label');

    if (isNaN(num1) || isNaN(num2)) {
        alert("Digite dois números válidos!");
        return;
    }

    let resultado = 0;
    const positivo = Math.abs(num2)
    const sinal = (num1 < 0 && num2 >= 0) || (num1 >= 0 && num2 < 0) ? -1 : 1;

    for (let i = 0; i < positivo; i++) {
        resultado += Math.abs(num1);
    }

    resultado *= sinal;

    label.innerText =`${resultado}`;
}
