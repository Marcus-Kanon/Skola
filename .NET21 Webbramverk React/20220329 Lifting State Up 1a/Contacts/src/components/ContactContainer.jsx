import React from 'react';
import { useState } from 'react';
import ContactForm from './ContactForm';
import ContactList from './ContactList';
import './ContactContainer.css';

function ContactContainer() {
    const [IsContactFormVisible, setIsContactFormVisible] = useState(false);

    const [contacts, setContacts] = useState([
        {
            name: 'John Doe',
            email: 'johndoe@whatever.com',
            phone: '123456789'
        },
        {
            name: 'Jane Doe',
            email: 'janedoe@whatever.com',
            phone: '123456789'
        }
    ]);

    const addContact = contact => {
        setContacts([...contacts, contact]);
    }

    const onDeleteContact = contact => {
        const newContacts = contacts.filter(c => c.email !== contact.email);
        setContacts(newContacts);
    }

    const onEditContact = editedContact => {
        const newContacts = contacts.map(c => {
            if (c.email === editedContact.email) {
                return editedContact;
            } else {
                return c;
            }
        });
        setContacts(newContacts);
    }

    const onAddContact = contact => {
        console.log(contact);
        setContacts([...contacts, contact]);
    }

    return ( 
        <div>
            <ContactList contacts={contacts} />
            <button onClick={() => {setIsContactFormVisible(!IsContactFormVisible)}}>Add Contact</button>

            <div className={IsContactFormVisible ? "ContactForm" : "ContactFormHidden"} >
                <ContactForm onAddContact={onAddContact} />
            </div>
        </div>
     );
}

export default ContactContainer;