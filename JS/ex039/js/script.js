function calcular() {
    const input = document.getElementById('massa');
    const label = document.getElementById('label');

    let massa = parseFloat(input.value);

    if (isNaN(massa) || massa <= 0) {
        alert("Digite uma massa válida!");
        return;
    }

    let tempo = 0;
    const intervalo = 50;

    while (massa >= 0.05) {
        massa /= 2;
        tempo += intervalo;
    }

    label.innerText = `O tempo necessário é de ${tempo} segundos.`;
}
