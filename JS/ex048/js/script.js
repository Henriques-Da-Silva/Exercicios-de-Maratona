const resultado = document.getElementById('label')

let termo = 3
let soma = 0

while (termo <= 6561) {
    soma += termo
    termo *= 3
}

resultado.innerHTML += `<h3>Soma total = ${soma}</h3>`
