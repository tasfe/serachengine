import java.util.Enumeration;
import java.util.ResourceBundle;
import java.util.HashMap;

public class MessageResource extends ResourceBundle {
	protected String welcome = "欢迎使用网络爬虫工具";
	protected String help = "这是一款测试版的爬虫工具";
	protected HashMap<String, String> attribute;

	public MessageResource() {
		this.attribute = new HashMap<String, String>();
	}

	@Override
	public Enumeration<String> getKeys() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	protected Object handleGetObject(String key) {
		// TODO Auto-generated method stub
		return null;
	}

}
