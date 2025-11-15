function Ordenar() {
    const input = document.getElementById("input").value.trim();
    const label = document.getElementById("label");

    if (input === "") {
        label.innerHTML = "<p>Por favor, digite pelo menos um nome.</p>";
        return;
    }

    const nomes = input.split(" ").filter(nome => nome !== "");

    nomes.sort((a, b) => a.localeCompare(b, 'pt', { sensitivity: 'base' }));

    label.innerHTML = `
        <p>${nomes.join(" ")}</p>
    `;
}
