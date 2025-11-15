const professoresM = {};
const professoresF = {};

function Determinar() {
    const codigo = parseInt(document.getElementById("inputCode").value);
    const sexo = document.getElementById("sexo").value;
    const horas = parseInt(document.getElementById("inputHoras").value);
    const label = document.getElementById("label");

    if (codigo === 99999) {
        for (const [cod, hrs] of Object.entries(professoresM)) {
            const bruto = hrs * 30;
            const liquido = bruto - bruto * 0.1;
            label.innerHTML += `<div id="dados"> <p>${cod}</p> <p> ${bruto.toFixed(2)}</p> <p> ${liquido.toFixed(2)}</p> </div>`;
        }

        for (const [cod, hrs] of Object.entries(professoresF)) {
            const bruto = hrs * 30;
            const liquido = bruto - bruto * 0.1;
            label.innerHTML += `<div id="dados"> <p>${cod}</p> <p> ${bruto.toFixed(2)}</p> <p> ${liquido.toFixed(2)}</p> </div>`;
        }

        return;
    }

    if (!isNaN(codigo) && !isNaN(horas) && sexo !== "") {
        if (sexo === "M") {
            professoresM[codigo] = horas;
        } else if (sexo === "F") {
            professoresF[codigo] = horas;
        } else {
            alert("Sexo inválido.");
        }

        document.getElementById("inputCode").value = "";
        document.getElementById("inputHoras").value = "";
    } else {
        alert("Preencha todos os campos.");
    }
}
