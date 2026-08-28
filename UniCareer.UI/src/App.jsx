import { useState, useEffect } from 'react';

function App() {
  const [transactions, setTransactions] = useState([]);

  useEffect(() => {
    // Nezapomeň případně upravit port (zde 5000) podle svého běžícího backendu
    fetch('http://localhost:5043/api/Transaction')
      .then(response => response.json())
      .then(data => setTransactions(data))
      .catch(error => console.error('Chyba při načítání:', error));
  }, []);

  return (
    <div style={{ padding: '2rem', fontFamily: 'system-ui' }}>
      <h1>Výpis transakcí</h1>
      {transactions.length === 0 ? (
        <p>Zatím tu nic není, nebo se data načítají...</p>
      ) : (
        <ul>
          {transactions.map(t => (
            <li key={t.id}>
              <strong>{t.amount} Kč</strong> (Kategorie ID: {t.categoryId})
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}

export default App;