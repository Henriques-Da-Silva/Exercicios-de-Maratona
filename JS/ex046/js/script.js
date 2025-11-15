let soma = 0
let x = 0

do{
    soma += x
    x++
} while(x < 11)

document.getElementById("label").innerText = `A soma é ${soma}`