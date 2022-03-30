import React from 'react';
function ViewContact(props) {
    const contact = props.contact;
    if(contact !== null) {
        return (
            <div>
                <h1>View Contact</h1>
                <ul>
                    <li>
                        <label>Name: </label>
                        <span>{contact.name}</span>
                    </li>
                    <li>
                        <label>Email: </label>
                        <span>{contact.email}</span>
                    </li>
                    <li>
                        <label>Phone: </label>
                        <span>{contact.phone}</span>
                    </li>
                </ul>
            </div>
        );
    }
    else {
        return (
            <div>
                <h1>View Contact</h1>
                <p>No contact selected</p>
            </div>
        );
    }
}

export default ViewContact;