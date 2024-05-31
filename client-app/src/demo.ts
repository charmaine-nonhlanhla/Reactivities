const duck1 = {
    name: 'huey',
    numLegs: 2,
    makeSound: (sound: string) => console.log(sound)
}

const duck2 = {
    name: 'duey',
    numLegs: 2,
    makeQuack: () => console.log('quack')

}
export const ducks = [duck1, duck2]