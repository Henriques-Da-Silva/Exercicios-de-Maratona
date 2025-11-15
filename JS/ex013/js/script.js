function Abreviar() {
    const input = document.getElementById("input");
    const label = document.getElementById("label");
    const nomeCompleto = input.value.trim();

    if (nomeCompleto === "") {
        label.textContent = "Por favor, digite um nome.";
        return;
    }

    const palavras = nomeCompleto.split(" ");
    const abreviado = palavras.map(palavra => {
        if (palavra.length <= 2) {
            return palavra;
        } else {
            return palavra[0].toUpperCase() + ".";
        }
    });

    label.innerHTML = `<p>${abreviado.join(" ")}</p>`;
}
