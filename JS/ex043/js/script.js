let maior = null

function Submeter() {
    const input = document.getElementById('num1')
    const label = document.getElementById('label')
    const valor = Number(input.value)

    if (input.value === "") {
        label.innerHTML = '<span style="color:red;">Digite um número válido!</span>'
        return
    }

    if (valor === 9999) {
        if (maior === null) {
            label.innerHTML = '<span style="color:red;">Nenhum número válido foi digitado.</span>'
        } else {
            label.innerHTML = `<span style="color:green; font-weight:bold;">Maior número digitado: ${maior}</span>`
        }
        input.value = ""
        input.disabled = true
        return
    }

    if (maior === null || valor > maior) {
        maior = valor
    }
    
    input.value = ""
    input.focus()
}
