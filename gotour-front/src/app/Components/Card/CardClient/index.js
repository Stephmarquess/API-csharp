
export default async function CardClient() {
	
	const cliente = await fetch('http://localhost:5129/api/Cliente').then(res => res.json());
	console.log(cliente);

	return (
		<main className="container">
			<h2 className='text-center'> Clientes </h2>
		
			<div>
				{cliente?.map((cliente) => (

					<div key={cliente.id} className="card w-50 mt-5 mx-auto shadow">
						<div className="card-body">
							<h5 className="card-title text-center">{cliente.nomeCliente}</h5>

							<details>
								<summary> Detalhes </summary>
								<p className="card-text mt-3">
									<span><strong>CPF:</strong> </span>{cliente.cpf}
								</p>
								<p className="card-text">
									<span><strong>E-mail:</strong></span> {cliente.email}
								</p>
								<p className="card-text">
									<span><strong>Endereço:</strong></span> {cliente.endereco}
								</p>
							</details>

						</div>
					</div>

				))}
			</div>
		</main>
	)
}