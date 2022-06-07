import React from 'react';
function Lista() {
    let data = [
        {
            id: 0,
            name: "Produkt 1",
            details: "blablabla"
        },
        {
            id: 1,
            name: "Produkt 2",
            details: "wawawawa"
        },
        {
            id: 2,
            name: "Produkt 3",
            details: "mohehe"
        }
    
    ];

    let elements = data.map(product => <li key={product.id}>Name: {data.name}<br />Details: {product.details}</li> )
    
    return ( 
        <ul>
            {elements}
        </ul>
     );
}
export default Lista;