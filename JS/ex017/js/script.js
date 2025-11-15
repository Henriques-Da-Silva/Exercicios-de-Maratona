let numeroDivisoes = 0;

function VerificarPrimo(n) {
    if (n <= 1) return false;
    if (n === 2) return true;

    for (let i = 2; i < n; i++) {
        numeroDivisoes++;
        if (n % i === 0) return false;
    }

    return true;
}

function Determinar() {
    const input = document.getElementById("input");
    const label = document.getElementById("label");
    const fim = parseInt(input.value);
    let resultado = "";
    numeroDivisoes = 0;

    if (isNaN(fim) || fim < 2) {
        alert("Digite o Número limite.");
        return;
    }

    for (let i = 0; i <= fim; i++) {
        if (VerificarPrimo(i)) {
            resultado += `${i} é primo.<br>`;
        }
    }

    resultado += `<br><strong>Foram executadas ${numeroDivisoes} divisões.</strong>`;
    label.innerHTML = resultado;
}