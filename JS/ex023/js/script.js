function Criar() {
    const input = document.getElementById("input");
    const label = document.getElementById("label");
    const base = parseInt(input.value);

    if (isNaN(base) || base < 5 || base > 15) {
        alert("Digite um número entre 5 e 15.");
        return;
    }

    let resultado = "<pre>";
    for (let i = 1; i <= base; i+=2) {
        resultado += "#".repeat(i) + "\n";
    }
    resultado += "</pre>";

    label.innerHTML = resultado;
}
