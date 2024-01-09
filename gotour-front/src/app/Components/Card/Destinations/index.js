
export default async function Card() {
	const destinos = await fetch('http://localhost:5129/api/Destinos').then(res => res.json());
	console.log(destinos); 
	
	return (
		<main className="container">
			<h2 className='text-center'> Destinos </h2>
		<div>			
			{destinos?.map((destinos) => (
				

		<div key={destinos.id} className="card mb-3 shadow mx-auto mt-5" style={{ maxWidth: 540 }}>
		<div className="row g-0">
			<div className="col-md-4">
			<img src={destinos.imagem} className="card-img-top img-thumbnail" alt={destinos.nome} />
			</div>
			<div className="col-md-8">
			<div className="card-body">
			<h5 className="card-title">{destinos.nome}</h5>
				<p className="card-text">
							{destinos.descricao}
				</p>
			</div>
			</div>
		</div>
		</div>
 
			))}
		</div>
		</main>		
	)
}
