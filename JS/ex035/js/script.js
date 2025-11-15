let listaNumeros = [];

function Proceder() {
    const input = document.getElementById("inputNum");
    const valor = input.value.trim();

    if (valor === "") {
        alert("Preencha o campo.");
        return;
    }

    listaNumeros.push(parseInt(valor));
    input.value = "";
}

function Parar() {
    const label = document.getElementById("label");

    if (listaNumeros.length === 0) {
        label.innerHTML = "<p>Nenhum número foi inserido.</p>";
        return;
    }

    const soma = listaNumeros.reduce((acc, val) => acc + val, 0);
    const total = listaNumeros.length;
    const media = soma / total;

    const positivos = listaNumeros.filter(n => n > 0).length;
    const negativos = listaNumeros.filter(n => n < 0).length;

    const percentualPositivos = ((positivos / total) * 100).toFixed(2);
    const percentualNegativos = ((negativos / total) * 100).toFixed(2);

    label.innerHTML = `
        <p>Média: ${media.toFixed(2)}</p>
        <p>${positivos} Positivos</p>
        <p>${negativos} Negativos</p>
        <p>Percentual de Positivos: ${percentualPositivos}%</p>
        <p>Percentual de Negativos: ${percentualNegativos}%</p>
    `;
    listaNumeros = [];
}
