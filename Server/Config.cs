using AutoMapper;
using Server.Automapper;
using Server.Repositories;
using Server.Services;

namespace Server
{
    public class Config
    {
        public UserRepository UserRepository { get; init; }
        public ChatRepository ChatRepository { get; init; }
        public MessageRepository MessageRepository { get; init; }
        public UserService UserService { get; init; }
        public MessageService MessageService { get; init; }
        public Mapper Mapper { get; init; }

        public Config()
        {
            AppDbContext context = new AppDbContext();
            UserRepository = new UserRepository(context);
            ChatRepository = new ChatRepository(context);
            MessageRepository = new MessageRepository(context);

            MapperConfiguration configuration = new MapperConfiguration((cfg) =>
            {
                cfg.AddProfile(typeof(ChatAutomapperProfile));
                cfg.AddProfile(typeof(UserAutomapperProfile));
                cfg.AddProfile(typeof(MessageAutomapperProfile));
            });

            Mapper = new Mapper(configuration);

            UserService = new UserService(UserRepository, Mapper);
            MessageService = new MessageService(MessageRepository, UserService);
        }
    }
}
