import React from 'react';
function ViewContact(contact) {
    return ( 
        <div>
            <h1>View Contact</h1>
            <ul>
                <li>
                    <label>Name:</label>
                    <span>{contact.name}</span>
                </li>
                <li>
                    <label>Email:</label>
                    <span>{contact.email}</span>
                </li>
                <li>
                    <label>Phone:</label>
                    <span>{contact.phone}</span>
                </li>
            </ul>
        </div>
     );
}

export default ViewContact;