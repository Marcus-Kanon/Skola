import React from 'react';
function ContactForm(props) {

    const handleSubmit = e => {
        e.preventDefault();
        const form = e.target;

        const contact = {
            name: form.name,
            email: form.email,
            phone: form.phone
        };
        console.log(contact);
        props.onAddContact(contact);
    }

    return ( 
        <div>
            <h1>Contact Form</h1>
            <form>
                <label>Name: </label>
                <input name="name" type="text" /><br />
                <label>Email: </label>
                <input name="email" type="text" /><br />
                <label>Phone: </label>
                <input name="phone" type="text" /><br />
                <button onClick={handleSubmit}>Send</button>
            </form>
        </div>
     );
}

export default ContactForm;