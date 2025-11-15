function somaDivs(n) {
    let soma = 1;
    for (let i = 2; i <= Math.sqrt(n); i++) {
        if (n % i === 0) {
            soma += i;
            const outroDivisor = n / i;
            if (outroDivisor !== i) soma += outroDivisor;
        }
    }
    return soma;
}

function Calcular() {
    const somaMap = new Map();

    for (let a = 2; a <= 100000; a++) {
        const b = somaDivs(a);
        if (b > a && b <= 100000) {
            const somaB = somaMap.has(b) ? somaMap.get(b) : somaDivs(b);
            somaMap.set(a, b);
            somaMap.set(b, somaB);
            if (somaB === a) {
                document.getElementById('label').innerHTML += `<p>${a} e ${b} são amigos.</p>`;
            }
        }
    }
}

Calcular();