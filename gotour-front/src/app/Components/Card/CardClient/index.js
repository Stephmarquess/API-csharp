
export default async function CardClient() {
	
	const cliente = await fetch('http://localhost:5129/api/Cliente').then(res => res.json());
	console.log(cliente);

	return (
		<main className="container">
			<h2 className='text-center'> Clientes </h2>
			<>
				{/* INICIO DA MODIFICAÇÃO ADICIONANDO MODAL */}

				<div className="container d-flex justify-content-center mt-5">
					<button type="button" className="btn btn-primary w-auto" data-bs-toggle="modal" data-bs-target="#exampleModal">
						Cadastrar Cliente
					</button>
				</div>
				{/* Modal */}
				<div
					className="modal fade"
					id="exampleModal"
					tabIndex={-1}
					aria-labelledby="exampleModalLabel"
					aria-hidden="true"
				>
					<div className="modal-dialog">
						<div className="modal-content">
							<div className="modal-header">
								<h1 className="modal-title fs-5" id="exampleModalLabel">
									Cadastro de cliente
								</h1>
								<button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close" />
							</div>
							<div className="modal-body p-5">
								<form action="@{/cliente/cadastrar}" object="${cliente}" method="post">
									<div className="mb-3">
										<label htmlFor="nome" className="form-label fs-5">
											Nome Completo
										</label>
										<input type="text" className="form-control"
											id="nomeCompleto"
											placeholder="Digite o nome completo"
											field="*{nomeCliente}"
										/>
									</div>
									<div className="mb-3">
										<label htmlFor="cpf" className="form-label fs-5">
											CPF
										</label>
										<input
											type="text"
											className="form-control"
											id="cpf"
											placeholder="Digite o cpf"
											field="*{cpf}"
											onkeypress="cpfMask()"
											minLength={14}
											maxLength={14}
										/>
									</div>
									<div className="mb-3">
										<label htmlFor="email" className="form-label fs-5">
											E-mail
										</label>
										<input
											type="email"
											className="form-control"
											id="email"
											placeholder="Digite o e-mail"
											field="*{email}"
										/>
									</div>
									<div className="mb-3">
										<label htmlFor="endereco" className="form-label fs-5">
											Endereço (Rua, nº , bairro, cidade, UF)
										</label>
										<input
											type="text"
											className="form-control"
											id="endereco"
											placeholder="Digite o endereço completo"
											field="*{endereco}"
										/>
									</div>
									<div className="d-flex justify-content-center mb-5 mt-5">
										<button className="btn btn-primary">Cadastrar</button>
									</div>
								</form>

							</div>
							<div className="modal-footer d-flex justify-content-center">
								<button type="button" className="btn btn-secondary" data-bs-dismiss="modal">
									Fechar
								</button>

							</div>
						</div>
					</div>
				</div>
			</>

			{/* ADICIONANDO MODAL */}




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