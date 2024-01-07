import styles from './card.module.css';


export default async function Card() {
	const destinos = await fetch('http://localhost:5129/api/Destinos').then(res => res.json());
	console.log(destinos); 
	
	return (
		<main className="container">
			<h2 className='text-center'> Destinos </h2>
		<div>			
			{destinos?.map((destinos) => (
				
				<div key={destinos.id} className="card w-50 mt-5 mx-auto">
				<img src={destinos.imagem} className="card-img-top" alt={destinos.nome} />
				<div className="card-body">
				<h5 className="card-title">{destinos.nome}</h5>
				<p className="card-text">
					{destinos.descricao}
				</p>				
				</div>
				</div>
 
			))}
		</div>
		</main>		
	)
}
