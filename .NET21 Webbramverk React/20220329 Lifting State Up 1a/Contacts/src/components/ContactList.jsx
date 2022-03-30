import React from 'react';
import { useState } from 'react';

function ContactList(props) {

    return ( 
        <div>
            <h1>Contact List</h1>
            <ul>
                {props.contacts.map(contact => (
                    <li key={contact.email}>
                        <a onClick={() => props.onSelectContact(contact)} href="#">{contact.name}</a>
                    </li>
                ))}
            </ul>
        </div>
     );
}

export default ContactList;