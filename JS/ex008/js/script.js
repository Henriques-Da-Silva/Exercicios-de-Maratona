for (let num = 1000; num <= 9999; num++){
    let numero = String(num);

    const num1 = Number(numero.slice(0, 2));
    const num2 = Number(numero.slice(2));

    const soma = num1 + num2;
    const resultado = Math.pow(soma, 2);
    if (resultado == num)
    {
        document.getElementById('label').innerHTML += `<p>${num}</p>`;
    }
}