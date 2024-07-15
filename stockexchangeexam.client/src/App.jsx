import React, { useState } from 'react';
import SaleForm from './components/SaleForm';
import Result from './components/Result';
import './App.css'

const App = () => {
    const [profit, setProfit] = useState(null);

    const handleCalculate = async (saleRequest) => {
        const response = await fetch('/api/accounting/calculate', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(saleRequest),
        });

        const result = await response.json();
        setProfit(result);
    };

    return (
        <div class="section">
            <h1>Stock Profit Calculator</h1>
            <SaleForm onCalculate={handleCalculate} />
            {profit !== null && <Result profit={profit} />}
        </div>
    );
};

export default App;