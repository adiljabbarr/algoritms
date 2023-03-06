// ekobunu tapmaq meselesi

const eded1 = prompt('Enter a first positive integer: ');
const eded2 = prompt('Enter a second positive integer: ');

let min = (eded1 > eded2) ? eded1 : eded2;

// fornan uzun olacaq deye while isletdim burada
while (true) {
    if (min % eded1 == 0 && min % eded2 == 0) {
        console.log(`ekob: ${min}`);
        break;
    }
    min++;
}