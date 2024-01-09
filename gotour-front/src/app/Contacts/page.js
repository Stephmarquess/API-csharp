import styles from './contato.module.css';

export default function Contato() {
    return (

<div className={styles.contatos}>
  <h1 style={{ textAlign: "center",  marginTop: 10 }}>Contatos úteis</h1>
  <div className="contatos" style={{ textAlign: "center" }}>
    <p>
      <strong> Seguro Viagem</strong> <br /> (11) 3749-8000
    </p>
    <p>
      <strong> Serviço de Transfer</strong>
      <br /> (11) 3749-5549
    </p>
    <p>
      <strong> Gerencia</strong>
      <br /> (21) 3512-2500
    </p>
    <p>
      <strong> Central</strong> <br /> (11) 9999-9999
    </p>
  </div>
</div>

    )
  }