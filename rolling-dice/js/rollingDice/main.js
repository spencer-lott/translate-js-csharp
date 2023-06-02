// Put your code here
console.log("Let's roll some dice, baby!")
console.log("---------------------------")

const Roll = () => {
    let dieValue = Math.floor((Math.random() * 6) + 1);
    switch (dieValue) {
        case 1 :
        dieString = 'one';
        break;
        case 2 : 
        dieString = 'two';
        break;
        case 3 :
        dieString = 'three';
        break;
        case 4 :
        dieString = 'four';
        break;
        case 5 :
        dieString = 'five';
        break;
        case 6 :
        dieString = 'six';
        break;
    }

    return dieString
}


const RollBoth = () => {

    for (let i =0; i < 10; i++) {
        die1 = Roll();
        die2 = Roll();
        
        let conversionD1 = () => {
            if (die1 === 'one') {
                return 1;
            } else if (die1 === 'two') {
                return 2;
            } else if (die1 === 'three') {
                return 3;
            } else if (die1 === 'four') {
                return 4;
            } else if (die1 === 'five') {
                return 5;
            } else if (die1 === 'six') {
                return 6;
            }
        }; 
    
        let conversionD2 = () => {
            if (die2 === 'one') {
                return 1;
            } else if (die2 === 'two') {
                return 2;
            } else if (die2 === 'three') {
                return 3;
            } else if (die2 === 'four') {
                return 4;
            } else if (die2 === 'five') {
                return 5;
            } else if (die2 === 'six') {
                return 6;
            }
        }; 

        message = `${die1} + ${die2} == ${conversionD1() + conversionD2()}`;
        if (die1 === die2)
        {
            message += " DOUBLES!";
        }
    
        console.log(message);
    }
}

RollBoth();
