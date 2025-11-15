let qPares = 0
let qImpares = 0

function Submeter() {
    const input = document.getElementById('num1')
    const label = document.getElementById('label')
    const valor = Number(input.value)

    if (input.value === "") {
        label.innerHTML = '<span style="color:red;">Digite um número válido!</span>'
        return
    }

    if (valor === 9999) {
        if (qPares === 0 && qImpares === 0) {
            label.innerHTML = '<span style="color:red;">Nenhum número válido foi digitado.</span>'
        } else {
            label.innerHTML = `<span style="color:green; font-weight:bold;">Pares = ${qPares}</span> <span style="color:green; font-weight:bold;">Impares = ${qImpares}</span>`
        }
        input.value = ""
        input.disabled = true
        return
    }

    if (valor % 2 === 0) {
        qPares++
    } else {
        qImpares++
    }
    
    input.value = ""
    input.focus()
}