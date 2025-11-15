var lista_numeros = []

function Calcular(){
    document.getElementById('label').innerHTML = `<p></p>`

    let numero = document.getElementById('input').value
    
    if (numero >= 0){
        lista_numeros.push(numero)
        document.getElementById('input').value = ''
    } else{
        Calcular_Media(lista_numeros)
    }
}

function Calcular_Media(lista){
    let soma = 0
    
    if (lista.length != 0){
        for (num of lista){ soma += Number(num) }
    
        media = soma / lista.length
    
        document.getElementById('label').innerHTML = `<p>Média: ${media}</p>`
        lista_numeros = []
    }
}