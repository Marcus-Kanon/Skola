class template {
    static get counter() {
        return this.count;
    }

    static set counter(value) {
        template.count=value;
    }

    constructor(name="test", lastname="test", password="test")
    {
        template.counter++;
        this.id = template.counter;
        this.name = name;
        this.lastname = lastname;
        this.password = password;
    }
}

template.counter = 0;

let person1 = new template('marcus', 'kanon', 123);
let person2 = new template('asdasd', 'asdasd', 321);

let data = [person1, person2]

for (let i = 0; i < 10; i++) {
    data.push(new template());
}

data.forEach(data => console.log(data.id + ". " + data.name));


