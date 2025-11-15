let variacao
let etapa = 0
let calculosFeitos = 0
let totalCalculos = 0
let numA = 0

function Determinar(){
    const variacaoInput = document.getElementById('opcao')
    const resultado = document.getElementById('label')
    const instruction = document.getElementById('variacao')

    if (etapa === 0) {
        variacao = variacaoInput.value
        
        if (!variacao) {
            resultado.innerHTML = '<span style="color: red;">Opção inválida! Por favor, tente novamente.</span>'
            return
        }
        
        if (variacao === '2') {
            resultado.innerHTML = '<span style="color: red;">Nenhum código disponível para esta opção.</span>'
            return
        }
        
        etapa = 1
        variacaoInput.style.display = 'none'
        
        if (variacao === '1') {
            totalCalculos = 10
            instruction.textContent = 'Informe o valor de A:'
        } else if (variacao === '3') {
            totalCalculos = 100
            instruction.textContent = 'Informe o valor de A:'
        } else if (variacao === '4') {
            instruction.textContent = 'Informe quantas vezes deseja executar:'
        }
        
        const input = document.createElement('input')
        input.type = 'number'
        input.id = 'valor-input'
        input.step = 'any'
        document.getElementById('input-div').insertBefore(input, document.getElementById('btn'))
        
        resultado.innerHTML = ''
        
    } else if (etapa === 1) {
        const valorInput = document.querySelector('#valor-input')
        
        if (variacao === '4') {
            const numN = parseInt(valorInput.value)
            
            if (isNaN(numN) || numN <= 0) {
                resultado.innerHTML = '<span style="color: red;">Valor inválido!</span>'
                valorInput.value = ''
                valorInput.focus()
                return
            }
            
            totalCalculos = numN
            etapa = 2
            instruction.textContent = 'Informe o valor de A:'
            resultado.innerHTML = ''
            valorInput.value = ''
            valorInput.focus()
            return
        }
        
        etapa = 2
        instruction.textContent = 'Informe o valor de A:'
        resultado.innerHTML = ''
        valorInput.value = ''
        valorInput.focus()
        
    } else if (etapa === 2) {
        const valorInput = document.querySelector('#valor-input')
        numA = parseFloat(valorInput.value)
        
        if (isNaN(numA)) {
            resultado.innerHTML = '<span style="color: red;">Valor inválido!</span>'
            valorInput.value = ''
            valorInput.focus()
            return
        }
        
        etapa = 3
        instruction.textContent = 'Informe o valor de B:'
        resultado.innerHTML = ''
        valorInput.value = ''
        valorInput.focus()
        
    } else if (etapa === 3) {
        const valorInput = document.querySelector('#valor-input')
        const numB = parseFloat(valorInput.value)
        
        if (isNaN(numB)) {
            resultado.innerHTML = '<span style="color: red;">Valor inválido!</span>'
            valorInput.value = ''
            valorInput.focus()
            return
        }
        
        if (numB === 0) {
            resultado.innerHTML = '<span style="color: red;">Divisão por zero não é permitida, tente novamente.</span>'
            valorInput.value = ''
            valorInput.focus()
            return
        }
        
        console.log(numA, numB)
        let modulo = numA % numB
        calculosFeitos++
        
        resultado.innerHTML = `<span style="color: green;">O resultado do módulo é: ${modulo}</span>`
        
        if (calculosFeitos < totalCalculos) {
            instruction.textContent = 'Informe o valor de A:'
            valorInput.value = ''
            valorInput.focus()
            etapa = 2
        } else {
            resultado.innerHTML += `<div style="margin-top: 10px; color: blue; font-weight: bold;">Todos os ${totalCalculos} cálculos foram concluídos!</div>`
            
            document.getElementById('btn').textContent = 'Calcular Novamente'
            document.getElementById('btn').addEventListener('click', function() {
                location.reload()
            }, { once: true })
        }
    }
}