// src/components/SaleForm.js

import React, { useState } from 'react';

const SaleForm = ({ onCalculate }) => {
    const [sharesToSell, setSharesToSell] = useState('');
    const [sellingPricePerShare, setSellingPricePerShare] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        onCalculate({ sharesToSell: parseInt(sharesToSell), sellingPricePerShare: parseFloat(sellingPricePerShare) });
    };

    return (
        <form onSubmit={handleSubmit} style={{ display: "flex", gap: "5px", alignItems: "center" }}>
            <div>
                <label>Shares to Sell:</label>
                <input type="number" value={sharesToSell} onChange={(e) => setSharesToSell(e.target.value)} required style={{marginLeft: "5px"}} />
            </div>
            <div>
                <label>Selling Price per Share:</label>
                <input type="number" value={sellingPricePerShare} onChange={(e) => setSellingPricePerShare(e.target.value)} required style={{ marginLeft: "5px" }} />
            </div>
            <button style={{backgroundColor: "blue", color: "#ffff"}} type="submit">Calculate</button>
        </form>
    );
};

export default SaleForm;
