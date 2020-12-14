using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using dotNet_LabTwo.Models;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Input;

namespace dotNet_LabTwo.ViewModels
{
    public class Initializer
    {
        public static ObservableCollection<UserViewModel> Init()
        {
            ObservableCollection<UserViewModel> res = new ObservableCollection<UserViewModel>();
            res.Add(new UserViewModel(new User()
            {
                Name = "Александр",
                Surname = "Васильев",
                Group = 3,
                Diseases = new List<Disease>()
                {
                    new Disease()
                    {
                        Type = "Глаукома"
                    },
                    new Disease()
                    {
                        Type = "Катаракта"
                    },
                    new Disease()
                    {
                        Type = "Дальтонизм"
                    }
                }
            }));
            res.Add(new UserViewModel(new User()
            {
                Name = "Мария",
                Surname = "Петрова",
                Group = 3,
                Diseases = new List<Disease>()
                {
                    new Disease()
                    {
                        Type = "Глаукома"
                    },
                    new Disease()
                    {
                        Type = "Катаракта"
                    },
                }
            }));
            res.Add(new UserViewModel(new User()
            {
                Name = "Алексей",
                Surname = "Синицын",
                Group = 3,
                Diseases = new List<Disease>()
                {
                    new Disease()
                    {
                        Type = "Дальтонизм"
                    },
                    new Disease()
                    {
                        Type = "Катаракта"
                    },
                    new Disease()
                    {
                        Type = "Миопия"
                    },
                    new Disease()
                    {
                        Type = "Блефарит"
                    },
                }
            }));
            res.Add(new UserViewModel(new User()
            {
                Name = "Евгений",
                Surname = "Бокарев",
                Group = 2,
                Diseases = new List<Disease>()
                {
                    new Disease()
                    {
                        Type = "Деструкция"
                    },
                }
            }));
            res.Add(new UserViewModel(new User()
            {
                Name = "Олимпия",
                Surname = "Тетюхина",
                Group = 1,
                Diseases = new List<Disease>()
                {
                    new Disease()
                    {
                        Type = "Дегенерация макулы"
                    },
                    new Disease()
                    {
                        Type = "Глаукома"
                    },
                }
            }));
            return res;
        }

        public static ICollectionView initView(ObservableCollection<UserViewModel> UserList)
        {
            return CollectionViewSource.GetDefaultView(UserList);
        }
    }
}
