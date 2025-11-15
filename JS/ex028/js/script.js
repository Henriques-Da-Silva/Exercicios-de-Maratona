const label = document.getElementById("label");

const valores = [
    12, -5, 7, 0, -3, 18, 25, -10, 4, -1,
    9, 6, -8, 15, -12, 3, 11, -7, 2, 5,
    -4, 13, -6, 8, 10, -9, 14, -2, 1, 17,
    -11, 20, -13, 19, -14, 16, -15, 21, -16, 22,
    -17, 23, -18, 24, -19, 26, -20, 27, -21, 28
];

let somaPositivos = 0;
let qtdNegativos = 0;

for (let num of valores) {
    if (num > 0) {
        somaPositivos += num;
    } else if (num < 0) {
        qtdNegativos++;
    }
}

document.getElementById("valores").innerHTML += valores.join(", ");
label.innerHTML = `<p><strong>Soma dos números positivos:</strong> ${somaPositivos}</p> <p><strong>Quantidade de valores negativos:</strong> ${qtdNegativos}</p>`;