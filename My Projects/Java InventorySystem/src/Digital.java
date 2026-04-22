import java.time.LocalDateTime;

public class Digital extends Product 
{
	//fields 
	private String link;
	private LocalDateTime expirationDate;
	
	
	public Digital(String link2, LocalDateTime expirationDate2) {
		// TODO Auto-generated constructor stub
	}

	//getter
	public String getLink() 
	{
		return link;
	}
	
	public LocalDateTime getDate ()
	{
		return expirationDate;
	}
	
	//setters
	public void setLink(String url)
	{
		link = url;
	}
	
	public void setExp(LocalDateTime expDate)
	{
		expirationDate = expDate;
	}
}
