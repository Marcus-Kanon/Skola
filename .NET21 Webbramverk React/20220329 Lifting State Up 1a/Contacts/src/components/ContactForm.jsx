import React from 'react';
function ContactForm(props) {
    let name = "";
    let email = "";
    let phone = "";

    const handleSubmit = e => {
        e.preventDefault();

        const contact = {
            name: name,
            email: email,
            phone: phone
        };
        console.log(contact);
        props.onAddContact(contact);
    }

    return ( 
        <div>
            <h1>Contact Form</h1>
            <form>
                <label>Name: </label>
                <input onChange={(e) => {name = e.target.value}} name="name" type="text" /><br />
                <label>Email: </label>
                <input onChange={(e) => {email = e.target.value}} name="email" type="text" /><br />
                <label>Phone: </label>
                <input onChange={(e) => {phone = e.target.value}} name="phone" type="text" /><br />
                <button onClick={handleSubmit}>Send</button>
            </form>
        </div>
        );
}

export default ContactForm;