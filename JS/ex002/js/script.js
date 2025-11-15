function Calcular(){
    let num1 = document.getElementById('num1').value
    let num2 = document.getElementById('num2').value
    let num3 = document.getElementById('num3').value

    if (num1 !== '' && num2 !== '' && num3 !== ''){
        const media = (Number(num1)+Number(num2)+Number(num3))/3   
        document.getElementById('label').innerHTML = `<p>Média: ${media}<p>` 
    }else{alert('Preencha todos os Campos.')}
}