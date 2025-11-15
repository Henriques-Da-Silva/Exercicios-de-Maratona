function Calcular(){
    let num1 = document.getElementById('num1').value
    let num2 = document.getElementById('num2').value
    let num3 = document.getElementById('num3').value

    if (num1 !== '' && num2 !== '' && num3 !== ''){
        a = Number(num1)
        b = Number(num2)
        c = Number(num3)

        if (a+b>c && a+c>b && b+c>a){
            if (a == b && a == c && b == c){
                document.getElementById('label').innerHTML = `<p>Triângulo Equiláleto.<p>`
            } else if(a == b || a == c || b == c){
                document.getElementById('label').innerHTML = `<p>Triângulo Isósceles.<p>`
            } else{
                document.getElementById('label').innerHTML = `<p>Triângulo Escaleno.<p>`
            }
        }else{
             document.getElementById('label').innerHTML = `<p>Não formam um Triângulo.<p>`
        }

    }else{alert('Preencha todos os Campos.')}
}