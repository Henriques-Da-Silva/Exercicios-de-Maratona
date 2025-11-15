const quantidade = 15
let sequencia_fibonacci = []

if (quantidade >= 1){sequencia_fibonacci.push(0)}
if (quantidade >= 2){sequencia_fibonacci.push(1)}

for (let i = sequencia_fibonacci.length; i < quantidade; i++){
    let novo = sequencia_fibonacci[i-1] + sequencia_fibonacci[i-2]
    sequencia_fibonacci.push(novo)
}

for (num of sequencia_fibonacci){
    document.getElementById('label').innerHTML += `<p>${num}</p>`
}