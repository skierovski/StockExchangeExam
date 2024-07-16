import { useState } from 'react';
import SaleForm from './components/SaleForm';
import Result from './components/Result';
import './App.css'

const App = () => {
    const [profit, setProfit] = useState(null);
    const [error, setError] = useState(null);

    const handleCalculate = async (saleRequest) => {
        try {
            const response = await fetch('https://localhost:7272/api/Accounting/calculate', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(saleRequest),
            });
            // very simple exemption handling
            if (!response.ok) {
                throw new Error('Failed to calculate profit');
            }

            const result = await response.json();
            setProfit(result);
            setError(null);
        } catch (error) {
            setError(error.message);
        }
    };

    return (
        <div className="section">
            <h1>Stock Profit Calculator</h1>
            <SaleForm onCalculate={handleCalculate} />
            {error && <p className="error">{error}</p>}
            {profit !== null && <Result profit={profit} />}
        </div>
    );
};

export default App;