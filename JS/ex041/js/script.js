const label = document.getElementById('label');

function gerarFibonacci(termos) {
    const fib = [0, 1]

    for (let i = 2; i < termos; i++) {
        fib[i] = fib[i - 1] + fib[i - 2]
    }
    return fib;
}

const fibonacci20 = gerarFibonacci(20);

label.innerText = `${fibonacci20.join('\n')}`;
