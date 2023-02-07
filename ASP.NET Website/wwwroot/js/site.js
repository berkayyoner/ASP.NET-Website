function TestAlert(Message) {
    alert(Message);
    document.getElementById("WC").innerHTML = message;
}

function Calculator() {
    var num1 = parseInt(document.getElementById("index1").value);
    var num2 = parseInt(document.getElementById("index2").value);

    const radioButtons = document.querySelectorAll('input[name="operator"]');
    let selectedOperator;
    for (const radioButton of radioButtons) {
        if (radioButton.checked) {
            selectedOperator = radioButton.value;
        }
    }

    if (selectedOperator == "+") {
        document.getElementById("answer").innerHTML = num1 + num2;
    }
    else if (selectedOperator == "-") {
        document.getElementById("answer").innerHTML = num1 - num2;
    }
    else if (selectedOperator == "*") {
        document.getElementById("answer").innerHTML = num1 * num2;
    }
    else if (selectedOperator == "/") {
        document.getElementById("answer").innerHTML = num1 / num2;
    }
}

