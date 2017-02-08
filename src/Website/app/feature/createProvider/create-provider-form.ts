export class CreateProviderForm{
    npi: string;
    firstName: string;
    lastName: string;

    mailingAddress: Address;
    practiceAddress: Address;

    constructor() {
        this.mailingAddress = new Address();
        this.practiceAddress = new Address();
    }
}

class Address {
    streetOne: string;
    streetTwo: string;
    city: string;
    state: string;
    zip: string;
}