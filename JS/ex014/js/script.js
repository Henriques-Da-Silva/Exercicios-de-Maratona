function Determinar() {
    const palavra1 = document.getElementById("input1").value.trim().toLowerCase();
    const palavra2 = document.getElementById("input2").value.trim().toLowerCase();
    const label = document.getElementById("label");

    if (palavra1 === "" || palavra2 === "") {
        alert("Preencha todos os Campos!");
        return;
    }

    let resultado = "";

    if (palavra1 === palavra2) {
        resultado = "AS PALAVRAS DIGITADAS SÃO IGUAIS.";
    } else {
        if (palavra1.length === palavra2.length) {
            resultado = "As palavras digitadas são diferentes, mas de igual comprimento.";
        } else if (palavra1.length > palavra2.length) {
            resultado = "A primeira palavra tem maior comprimento.";
        } else {
            resultado = "A segunda palavra tem maior comprimento.";
        }

        if (palavra1.includes(palavra2)) {
            resultado += "<br>A segunda palavra é subString da primeira.";
        }
    }

    label.innerHTML = `<p>${resultado}</p>`;
}
