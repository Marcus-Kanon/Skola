import React from "react";

function ProductDetails() {

const product = {
        name: 'Hammare',
        price: 125,
        img: 'http://clipart-library.com/images/rcLxeLe6i.jpg'
        }
        

    return (
    <div>
        <h3>{product.name}</h3>
        Price: {product.price}
        <img src={product.img} alt="" />
    </div>);
}

export default ProductDetails;