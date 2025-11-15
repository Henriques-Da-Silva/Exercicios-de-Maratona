function Montar() {
    const num = parseInt(document.getElementById("inputNumero").value);
    const inicio = parseInt(document.getElementById("inputInicio").value);
    const fim = parseInt(document.getElementById("inputFim").value);
    const label = document.getElementById("label");

    if (isNaN(num) || isNaN(inicio) || isNaN(fim)) {
        alert("Preencha todos os campos.");
        return;
    }

    if (inicio >= fim) {
        alert("Fim não pode ser menor ou igual que o início.");
        return;
    }

    let resultado = "<p></p>";
    for (let i = inicio; i <= fim; i++) {
        resultado += `${num} x ${i} = ${num * i}<br>`;
    }

    label.innerHTML = resultado;
}
