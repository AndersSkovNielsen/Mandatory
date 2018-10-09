const gramMultiplier: number = 28.34952;
const ounceMultiplier: number = 0.03527396195;

function toOunces(weight: number): string {
    return weight * ounceMultiplier + " ounces";
}

function convertToOunces(): void{
    let result: HTMLOutputElement = <HTMLOutputElement> document.getElementById("result");

    let weight: HTMLInputElement = <HTMLInputElement> document.getElementById("weight")
    let tal: number = Number(weight.value);
    let conversion: string = toOunces(tal);

    result.innerHTML = conversion;
}

function toGrams(weight: number): string {
    return weight * gramMultiplier + " grams";
}

function convertToGrams(): void{
    let result: HTMLOutputElement = <HTMLOutputElement> document.getElementById("result");

    let weight: HTMLInputElement = <HTMLInputElement> document.getElementById("weight")
    let tal: number = Number(weight.value);
    let conversion: string = toGrams(tal);

    result.innerHTML = conversion;
}

let oButton: HTMLButtonElement = <HTMLButtonElement> document.getElementById("OButton");

let gButton: HTMLButtonElement = <HTMLButtonElement> document.getElementById("GButton");

oButton.addEventListener("click", convertToOunces);

gButton.addEventListener("click", convertToGrams);